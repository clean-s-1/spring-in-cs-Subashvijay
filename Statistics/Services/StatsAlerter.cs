using System;
using System.Collections.Generic;
using System.Text;

namespace Statistics.Services
{
    public class StatsAlerter
    {
        private double _maxThreshold;
        private IAlerter[] _alerters;
        public StatsAlerter(double maxThreshold,IAlerter[] alerters)
        {
            _maxThreshold = maxThreshold;
            _alerters = alerters;
        }

        public void checkAndAlert(List<double> values)
        {
            foreach (var value in values)
            {
                if(value > _maxThreshold)
                {
                    foreach (var alerter in _alerters)
                    {
                        alerter.Alert();
                    }
                }

            }
        }

    }
}
