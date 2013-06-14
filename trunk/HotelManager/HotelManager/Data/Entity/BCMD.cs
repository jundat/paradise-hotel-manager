using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotelManager.Data.Entity
{
    public class BCMD : EntityAbstract
    {
        public int MaBCMD;
        public int ThangBaoCao;

        public BCMD() { }

        public BCMD(int _mabcmd, int _thangbaocao)
        {
            MaBCMD = _mabcmd;
            ThangBaoCao = _thangbaocao;
        }
    }
}
