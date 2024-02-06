using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MM_Autohandel {
    
    internal class SqlQuery
    {
        public StringBuilder build(string[] inputs)
        {
            int columns = 0;
            StringBuilder sqlquery = new StringBuilder();

            foreach (string input in inputs)
            {
                if (input != "")
                {
                    columns++;
                }
            }

            for (int i = 0; i < inputs.Length; i++)
            {
                if (inputs[i] != "")
                {
                    switch (i)
                    {
                        case 0:
                            sqlquery.Append("brand='" + inputs[i] + "' ");
                            break;
                        case 1:
                            if (columns > 1)
                            {
                                sqlquery.Append("OR model='" + inputs[i] + "' ");
                            }
                            else
                            {
                                sqlquery.Append("model='" + inputs[i] + "' ");
                            }
                            break;
                        case 2:
                            if (columns > 1)
                            {
                                sqlquery.Append("OR whp='" + inputs[i] + "' ");
                            }
                            else
                            {
                                sqlquery.Append("whp='" + inputs[i] + "' ");
                            }
                            break;
                    }
                }
            }

            return sqlquery;
        }
    }
}
