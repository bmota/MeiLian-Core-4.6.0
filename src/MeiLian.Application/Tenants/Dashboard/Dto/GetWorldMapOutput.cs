using System.Collections.Generic;

namespace MeiLian.Tenants.Dashboard.Dto
{
    public class GetWorldMapOutput
    {
        public GetWorldMapOutput(List<WorldMapCountry> countries)
        {
            Countries = countries;
        }

        public GetWorldMapOutput()
        {
            Countries= new List<WorldMapCountry>();
        }

        public List<WorldMapCountry> Countries { get; set; }

    }
}
