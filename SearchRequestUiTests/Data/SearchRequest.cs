namespace SearchRequestUiTests.Data
{
    class SearchRequest
    {
        private string targetSite;

        public string TargetSite
        {
            get => targetSite == null ? string.Empty : $"site:{targetSite}";
            set => targetSite = value;
        }

        public string SearchString { get; set; }
    }
}