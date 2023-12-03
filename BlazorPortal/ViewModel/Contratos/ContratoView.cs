namespace BlazorPortal.ViewModel.Contratos
{
    public class ContratoView
    {
        public string Id { get; set; } = string.Empty;
        public string IdOrganizacao { get; set; } = "650c946400015409e93dcc71";
        public string NumeroContrato { get; set; } = string.Empty;
        public string NumeroCliente { get; set; } = string.Empty;
        public string Descricao { get; set; } = string.Empty;
        public string TipoContratacao { get; set; } = string.Empty;
        public string FormaMedicao { get; set; } = string.Empty;
        public int Quantidade { get; set; }
        public DateTime DataContrato { get; set; }
        public DateTime PrazoVigencia { get; set; }
        public DateTime PrazoEscopo { get; set; }
        public DateTime PeriodoMedicaoInicio { get; set; }
        public DateTime PeriodoMedicaoFim { get; set; }
        public int PrazoComentariosDias { get; set; }

    }

    public enum TipoContratacao
    {
        
    }
}


/*{"_id":{"$oid":"650e166c1570e39755305ec5"},
 * "":"650c946400015409e93dcc71",
 * "":"EDS_6488-23",
 * "":"ECM_6488-23",
 * "":"zzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzzz",
 * "":"A1Equivalente",
 * "":"Fisica",
 * "":{"$numberInt":"1"},
 * "":{"$date":{"$numberLong":"1695416324077"}},
 * "":{"$date":{"$numberLong":"1695416324077"}},
 * "":{"$date":{"$numberLong":"1695416324077"}},
 * "":{"$date":{"$numberLong":"1695416324077"}},
 * "":{"$date":{"$numberLong":"1695416324077"}},
 * "":{"$numberInt":"0"}}*/