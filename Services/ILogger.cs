using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface ILogger
{
    void TrAcE(int level, string block, int line, string log);
}
