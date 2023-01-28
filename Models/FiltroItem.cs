namespace BuilderFilterDynamic.Models
{
    public class FiltroItem
    {
        protected FiltroItem() { }

        public FiltroItem(string prop, object value, string tipoFiltro)
        {
            Propriedade = prop;
            Value = value;
            FilterType = tipoFiltro;
        }

        public string Propriedade { get; set; }
        public object Value { get; set; }
        public string FilterType { get; set; }
        public FiltroItem And { get; set; }
        public FiltroItem Or { get; set; }
    }
}
