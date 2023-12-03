namespace BlazorPortal.ViewModel.LD
{
    public class TituloView
    {
        public SortedDictionary<int, string> Titulos { get; set; } = new SortedDictionary<int, string>();

        public void Add(int id, string val)
        {
            Titulos.Add(id, val);
        }

        public override string ToString()
        {
            string titulo = string.Empty;
            foreach (var item in Titulos)
            {
                titulo += item.Value + "\n";
            }
            return titulo.Trim();
        }
    }
}
