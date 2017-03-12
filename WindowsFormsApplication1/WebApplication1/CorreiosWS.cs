﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication1.CorreiosAtendeClienteService; //Adicionado para poder usar o WSDL dos correios

namespace WebApplication1
{
    class CorreiosWS
    {
        string cep;
        AtendeClienteClient ws;
        public enderecoERP endERP;

        public CorreiosWS()
        {
            ws = new AtendeClienteClient();
        }

        public void ConsultaCEP(string cep)
        {
            this.cep = cep;
            this.endERP = ws.consultaCEP(cep);
        }

       

    }
}
