using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Automotivo
{
    [Aluno("Thiago")]
    public class Roda
    {
        public enum EnumTipoRoda
        {
            Ferro,
            LigaLeve
        }

        public int Aro { get; set; }

        public EnumTipoRoda TipoRoda { get; set; }

        public static DataSet CarregarDataTableRodas()
        {
            var dataSet = new DataSet();
            dataSet.Tables.Add();
            dataSet.Tables[0].Columns.Add("Tipo de Roda");
            dataSet.Tables[0].Columns.Add("Aro");

            dataSet.Tables[0].Rows.Add(EnumTipoRoda.Ferro, 15);
            dataSet.Tables[0].Rows.Add(EnumTipoRoda.Ferro, 16);
            dataSet.Tables[0].Rows.Add(EnumTipoRoda.LigaLeve, 13);

            return dataSet;
        }

    }
}
