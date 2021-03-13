using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CapApi.Model;

namespace CapApi.Infrastructure
{
    public class CapDataRepository: ICapDataRepository
    {
        public CapDataRepository()
        {

        }
        public Task<IEnumerable<CapResultEntity>> getAll()
        {
            var result =  new List<CapResultEntity>()
            {
                new CapResultEntity("Strategic Management Accounting",
                    new List<YearGrade>()
                    {
                        new YearGrade(2015, "FAIL"),
                        new YearGrade(2016, "PASS")
                    }
                ),

                new CapResultEntity("Financial Reporting",
                    new List<YearGrade>()
                    {
                        new YearGrade(2015, "FAIL"),
                        new YearGrade(2016, "PASS")
                    }
                ),
                new CapResultEntity("Advanced Taxation",
                    new List<YearGrade>()
                    {
                      
                        new YearGrade(2016, "PASS")
                    }
                ),
                new CapResultEntity("Financial Risk Management",
                    new List<YearGrade>()
                    {
                        new YearGrade(2015, "PASS")
                    }
                ),
                  new CapResultEntity("Advanced Audit and Assurance",
                    new List<YearGrade>()
                    {
                        new YearGrade(2015, "PASS") 
                    }
                )

            };
            return Task.FromResult<IEnumerable<CapResultEntity>>(result);
        } 
    }
}


//[{"subject":"Strategic Management Accounting","results":[{"year":2015,"grade":"FAIL"},{"year":2016,"grade":"PASS"}]},
//{"subject":"Financial Reporting","results":[{"year":2015,"grade":"FAIL"},{"year":2016,"grade":"PASS"}]},
//{"subject":"Advanced Taxation","results":[{"year":2016,"grade":"PASS"}]},
//{"subject":"Financial Risk Management","results":[{"year":2015,"grade":"PASS"}]},
//{"subject":"Advanced Audit and Assurance","results":[{"year":2015,"grade":"PASS"}]}]