namespace BlazorPortal.ViewModel.LD
{
    public class CollectionLDView
    {
        private IQueryable<DocumentoView> _documentoViews;

        public IQueryable<DocumentoView> DocumentoViews { get => _documentoViews; }

        public CollectionLDView()
        {
            var doc1 = criarMocDocumento1();
            var doc2 = criarMocDocumento2();
            var doc3 = criarMocDocumento3();
            var doc4 = criarMocDocumento4();
            var doc5 = criarMocDocumento5();
            var doc6 = criarMocDocumento6();
            var doc7 = criarMocDocumento7();
            var doc8 = criarMocDocumento8();
            var doc9 = criarMocDocumento9();
            var doc10 = criarMocDocumento10();
            var doc11 = criarMocDocumento11();
            var doc12 = criarMocDocumento12();
            var doc13 = criarMocDocumento13();
            var doc14 = criarMocDocumento14();
            var doc15 = criarMocDocumento15();
            var doc16 = criarMocDocumento16();
            var doc17 = criarMocDocumento17();
            List<DocumentoView> lista = [doc1,
                doc2,
                doc3,
                doc4,
                doc5,
                doc6,
                doc7,
                doc8,
                doc9,
                doc10,
                doc11,
                doc12,
                doc13,
                doc14,
                doc15,
                doc16,
                doc17];
            _documentoViews = lista.AsQueryable();


        }

        private DocumentoView criarMocDocumento3()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223004";
            doc.NumeroCliente = "PH_223004";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "0";
            return doc;
        }

        private DocumentoView criarMocDocumento2()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "46608578-a1c4-45ac-ae17-f6ae9a763f73";
            doc.NumeroContrato = "EDS_PH_223008";
            doc.NumeroCliente = "PH_223008";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "ESTEIRA TRANSPORTADORA DE SAIDA");
            tituloView.Add(4, "TRANSLAÇÃO - DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "1";
            return doc;
        }

        private DocumentoView criarMocDocumento1()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "49535d59-3b5d-447e-a85e-5515ca9152e4";
            doc.NumeroContrato = "EDS_PH_223003";
            doc.NumeroCliente = "PH_223003";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - CALHAS DA ALIMENTAÇÃO");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "1";
            return doc;
        }

        private DocumentoView criarMocDocumento4()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223002";
            doc.NumeroCliente = "PH_223002";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "2";
            return doc;
        }

        private DocumentoView criarMocDocumento5()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223005";
            doc.NumeroCliente = "PH_223005";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "2";
            return doc;
        }

        private DocumentoView criarMocDocumento6()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223006";
            doc.NumeroCliente = "PH_223006";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "0";
            return doc;
        }

        private DocumentoView criarMocDocumento7()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223007";
            doc.NumeroCliente = "PH_223007";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "0";
            return doc;
        }

        private DocumentoView criarMocDocumento8()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223020";
            doc.NumeroCliente = "PH_223020";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "1";
            return doc;
        }

        private DocumentoView criarMocDocumento9()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223009";
            doc.NumeroCliente = "PH_223009";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "1";
            return doc;
        }

        private DocumentoView criarMocDocumento10()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223010";
            doc.NumeroCliente = "PH_223010";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "2";
            return doc;
        }

        private DocumentoView criarMocDocumento11()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223011";
            doc.NumeroCliente = "PH_223011";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "2";
            return doc;
        }

        private DocumentoView criarMocDocumento12()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223012";
            doc.NumeroCliente = "PH_223012";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "3";
            return doc;
        }

        private DocumentoView criarMocDocumento13()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223013";
            doc.NumeroCliente = "PH_223013";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "3";
            return doc;
        }

        private DocumentoView criarMocDocumento14()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223014";
            doc.NumeroCliente = "PH_223014";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "4";
            return doc;
        }

        private DocumentoView criarMocDocumento15()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223015";
            doc.NumeroCliente = "PH_223015";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "4";
            return doc;
        }

        private DocumentoView criarMocDocumento16()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223016";
            doc.NumeroCliente = "PH_223016";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "4";
            return doc;
        }

        private DocumentoView criarMocDocumento17()
        {
            var doc = new DocumentoView();
            var tituloView = new TituloView();
            doc.Id = "090e97bc-c379-455d-8c12-8d75690477f2";
            doc.NumeroContrato = "EDS_PH_223017";
            doc.NumeroCliente = "PH_223017";
            tituloView.Add(1, "PROJETO DETALHADO OTIMIZADO");
            tituloView.Add(2, "GALPÃO DE PROCESSOS - LAMA GROSSA");
            tituloView.Add(3, "FORNO DE BRIQUETES - TAMBORES");
            tituloView.Add(4, "DETALHES");
            doc.Titulo = tituloView.ToString();
            doc.Revisao = "0";
            return doc;
        }
    }
}
