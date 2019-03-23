using System;
using System.Collections.Generic;
using System.Text;

namespace Automotivo
{
    class Veiculo
    {
        public int VelocidadeAtual { get; set; }
        public bool IndicaLigado { get; set; }
        public Alarme Alarme { get; set; }
        public AnoFabricacaoModelo AnoFabricacaoModelo { get; set; }

        public Banco Banco { get; set; }
        public Blindagem Blindagem { get; set; }
        public Cambio Cambio { get; set; }
        public Carroceria Carroceria { get; set; }
        public Chassi Chassi { get; set; }
        public CorExterna CorExterna { get; set; }
        public CorInterna CorInterna { get; set; }
        public Direcao Direcao { get; set; }
        public Freio Freio { get; set; }
        public Placa Placa { get; set; }
        public Pneu Pneu { get; set; }
        public PortaMalas PortaMalas { get; set; }
        public Renavam Renavam { get; set; }
        public Roda Roda { get; set; }

    }
}
