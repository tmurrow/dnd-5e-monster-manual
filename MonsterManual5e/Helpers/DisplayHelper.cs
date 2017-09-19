using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MonsterManual5e.Helpers
{
    public static class DisplayHelper
    {
        public static string DisplayCR(float cr)
        {
            if (cr == 0.125)
            {
                return "<span class=\"fraction\"><sup>1</sup>&frasl;<sub>8</sub></span>";
            }
            else if (cr == 0.25)
            {
                return "<span class=\"fraction\"><sup>1</sup>&frasl;<sub>4</sub></span>";
            }
            else if (cr == 0.5)
            {
                return "<span class=\"fraction\"><sup>1</sup>&frasl;<sub>2</sub></span>";
            }
            else
            {
                return cr.ToString();
            }
        }
    }
}