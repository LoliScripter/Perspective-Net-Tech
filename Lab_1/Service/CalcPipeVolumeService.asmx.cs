﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Service
{
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    //[System.Web.Script.Services.ScriptService]
    public class CalcPipeVolumeService : WebService
    {
        [WebMethod(Description ="Calculate pipe volume: V=S*L", EnableSession =false, BufferResponse =true)]
        public double CalculatePipeVolume(double S, double L)
        {
            if(S >= 0 && L >= 0)
                return S * L;
            return 0;
        }
    }
}
