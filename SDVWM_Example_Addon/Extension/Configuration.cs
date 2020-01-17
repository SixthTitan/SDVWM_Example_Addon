
namespace SDVWM_Example_Addon.Extension
{
    class Configuration
    {
        /// <summary>
        // Get Weather Data from Weather Machine
        /// </summary>

        private string summary;
        public string Weather_Summary
        {
            get { return summary; }
            set { summary = value; }
        }
    }
}
