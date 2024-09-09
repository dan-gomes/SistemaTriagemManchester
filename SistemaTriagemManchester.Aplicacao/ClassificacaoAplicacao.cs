using Python.Runtime;
using SistemaTriagemManchester.Dominio;
using SistemaTriagemManchester.Dominio.Enums;
using SistemaTriagemManchester.Dominio.Interfaces.Repositorios;

namespace SistemaTriagemManchester.Aplicacao
{
    public class ClassificacaoAplicacao : IClassificacaoAplicacao
    {
        private readonly IUrgenciaRepositorio _urgenciaRepositorio;
        private readonly ISintomaRepositorio _sintomaRepositorio;
        public ClassificacaoAplicacao(IUrgenciaRepositorio urgenciaRepositorio, ISintomaRepositorio sintomaRepositorio)
        {
            _urgenciaRepositorio = urgenciaRepositorio;
            _sintomaRepositorio = sintomaRepositorio;
        }

        public double ClassificarComRandomForest(int[] sintomas)
        {
            double resultado = 0.0;

            PythonEngine.Initialize();

            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                dynamic sklearn = Py.Import("sklearn");
                dynamic sklearn_ensemble = Py.Import("sklearn.ensemble");
                dynamic sklearn_model_selection = Py.Import("sklearn.model_selection");
                dynamic train_test_split = sklearn_model_selection.train_test_split;
                dynamic sklearn_metrics = sklearn.metrics;
                dynamic accuracy_score = sklearn_metrics.accuracy_score;

                ObterDadosParaClassificacao(np, out dynamic X, out dynamic y);

                var split = train_test_split(X, y, test_size: 0.2, random_state: 42);
                dynamic X_train = split[0];
                dynamic X_test = split[1];
                dynamic y_train = split[2];
                dynamic y_test = split[3];

                dynamic clf = sklearn_ensemble.RandomForestClassifier(n_estimators: 100, random_state: 42);
                clf.fit(X_train, y_train);

                dynamic y_pred = clf.predict(X_test);
                dynamic accuracy = accuracy_score(y_test, y_pred);
                Console.WriteLine($"Acurácia do modelo RandomForest: {accuracy:.2f}");

                dynamic sintomasNp = np.array(sintomas).reshape(1, -1);
                dynamic urgencia = clf.predict(sintomasNp);
                resultado = (double)urgencia[0];
            }
            PythonEngine.Shutdown();

            return resultado;
        }

        private void ObterDadosParaClassificacao(dynamic np, out dynamic X, out dynamic y)
        {
            var sintomasM = _sintomaRepositorio.ObterSintomasParaTreinamento();
            var urgenciasM = _urgenciaRepositorio.ObterUrgenciasParaTreinamento();

            X = np.array(sintomasM.Select(s => new int[]
            {
                    Convert.ToInt16(s.Febre),
                    Convert.ToInt16(s.Tosse),
                    Convert.ToInt16(s.DorCabeca),
                    Convert.ToInt16(s.Fadiga),
                    Convert.ToInt16(s.SedeExcessiva),
                    Convert.ToInt16(s.MiccaoFrequente),
                    Convert.ToInt16(s.VisaoEmbacada),
                    Convert.ToInt16(s.Tremores),
                    Convert.ToInt16(s.ConfusaoMental),
                    Convert.ToInt16(s.SuorExcessivo)
            }).ToArray());

            y = np.array(urgenciasM.Select(a => Convert.ToInt16(a.Grau)).ToArray());
        }

        public double ClassificarComKNN(int[] sintomas)
        {
            double resultado = 0.0;

            PythonEngine.Initialize();
            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                dynamic sklearn_neighbors = Py.Import("sklearn.neighbors");
                dynamic sklearn_model_selection = Py.Import("sklearn.model_selection");
                dynamic train_test_split = sklearn_model_selection.train_test_split;
                dynamic sklearn_metrics = Py.Import("sklearn.metrics");
                dynamic accuracy_score = sklearn_metrics.accuracy_score;

                // Simulação de dados de exemplo
                ObterDadosParaClassificacao(np, out dynamic X, out dynamic y);

                // Dividindo o dataset em treinamento e teste
                var split = train_test_split(X, y, test_size: 0.2, random_state: 42);
                dynamic X_train = split[0];
                dynamic X_test = split[1];
                dynamic y_train = split[2];
                dynamic y_test = split[3];

                // Treinando o modelo KNeighborsClassifier
                dynamic clf = sklearn_neighbors.KNeighborsClassifier(n_neighbors: 3);
                clf.fit(X_train, y_train);

                // Avaliando o modelo no conjunto de teste
                dynamic y_pred = clf.predict(X_test);
                dynamic accuracy = accuracy_score(y_test, y_pred);
                Console.WriteLine($"Acurácia do modelo KNN: {accuracy:.2f}");

                // Classificando novos sintomas
                dynamic sintomasNp = np.array(sintomas).reshape(1, -1);
                dynamic urgencia = clf.predict(sintomasNp);
                resultado = (double)urgencia[0];
            }
            PythonEngine.Shutdown();

            return resultado;
        }

        // Método para Classificação usando Regressão Logística
        public double ClassificarComLogisticRegression(int[] sintomas)
        {
            double resultado = 0.0;

            PythonEngine.Initialize();
            using (Py.GIL())
            {
                dynamic np = Py.Import("numpy");
                dynamic sklearn_linear_model = Py.Import("sklearn.linear_model");
                dynamic sklearn_model_selection = Py.Import("sklearn.model_selection");
                dynamic train_test_split = sklearn_model_selection.train_test_split;
                dynamic sklearn_metrics = Py.Import("sklearn.metrics");
                dynamic accuracy_score = sklearn_metrics.accuracy_score;

                // Simulação de dados de exemplo
                ObterDadosParaClassificacao(np, out dynamic X, out dynamic y);

                // Dividindo o dataset em treinamento e teste
                var split = train_test_split(X, y, test_size: 0.2, random_state: 42);
                dynamic X_train = split[0];
                dynamic X_test = split[1];
                dynamic y_train = split[2];
                dynamic y_test = split[3];

                // Treinando o modelo LogisticRegression
                dynamic clf = sklearn_linear_model.LogisticRegression(random_state: 42);
                clf.fit(X_train, y_train);

                // Avaliando o modelo no conjunto de teste
                dynamic y_pred = clf.predict(X_test);
                dynamic accuracy = accuracy_score(y_test, y_pred);
                Console.WriteLine($"Acurácia do modelo Logistic Regression: {accuracy:.2f}");

                // Classificando novos sintomas
                dynamic sintomasNp = np.array(sintomas).reshape(1, -1);
                dynamic urgencia = clf.predict(sintomasNp);
                resultado = (double)urgencia[0];
            }
            PythonEngine.Shutdown();

            return resultado;
        }

        // Método para comparar os resultados dos três algoritmos e retornar a classificação final
        public Grau CompararClassificacoes(int[] sintomas)
        {
            double resultadoRF = ClassificarComRandomForest(sintomas);
            double resultadoKNN = ClassificarComKNN(sintomas);
            double resultadoLR = ClassificarComLogisticRegression(sintomas);

            // Comparar os resultados e decidir a classificação final (média simples)
            double media = (resultadoRF + resultadoKNN + resultadoLR) / 3;

            if (media >= 0.9)            
                return Grau.Emergencia;            
            else if (media >= 0.7)            
                return Grau.MuitoUrgente;            
            else if (media >= 0.5)            
                return Grau.Urgente;            
            else if (media >= 0.3)
                return Grau.PoucoUrgente;

            return Grau.NaoUrgente;
            
        }
    }
}


