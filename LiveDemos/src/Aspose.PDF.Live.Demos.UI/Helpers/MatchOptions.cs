namespace Aspose.Pdf.Live.Demos.UI.Helpers
{
    internal struct MatchOptions
    {
        /// <summary>
        /// Match granularity, defines how many words are joined into single block
        /// </summary>
        public int BlockSize { get; set; }

        public double RepeatingWordsAccuracy { get; set; }

        public bool IgnoreWhitespaceDifferences { get; set; }

    }
}
