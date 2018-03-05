using System;
using System.Text;

namespace webApi.Domain{
    public class Beer{
        public string GetBeer(){
            var beerBuilder = new StringBuilder();
            
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append("  _.._..,_,_");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append(" (          )");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append("  ]~,\"-.-~~[");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append(".=])' (;  ([");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append("| ]:: '    [");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append("'=]): .)  ([");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append("  |:: '    |");
            beerBuilder.Append(Environment.NewLine);
            beerBuilder.Append("   ~~----~~");
            beerBuilder.Append(Environment.NewLine);

            return beerBuilder.ToString();
        }

        internal string GetBeers(int number)
        {
            var beers = string.Empty;

            for(int i=0; i <= number; i++ ){
                beers = beers + GetBeer();
            }
            return beers;
        }
    }
}