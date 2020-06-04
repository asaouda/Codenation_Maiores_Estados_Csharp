using System;
using System.Collections.Generic;

namespace Codenation.Challenge
{
    public class Country
    {
        public State[] Top10StatesByArea()
        {
            State[] maioresEstados =
            {
                new State("Amazonas", "AM"),
                new State("Para", "PA"),
                new State("Mato Grosso", "MT" ),
                new State("Minas Gerais", "MG"),
                new State("Bahia", "BA"),
                new State("Mato Grosso do Sul", "MS"),
                new State("Goias", "GO"),
                new State("Maranhao", "MA"),
                new State("Rio Grande do Sul", "RS"),
                new State("Tocantins", "TO")
            };

            return maioresEstados;
        }
    }
}
