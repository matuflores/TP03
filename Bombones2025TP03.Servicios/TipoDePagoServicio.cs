﻿using Bombones2025TP03.DatosSql;
using Bombones2025TP03.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bombones2025TP03.Servicios
{
    public class TipoDePagoServicio
    {
        private readonly TipoDePagoRepositorio _tipoDePagoRepositorio = null!;

        public TipoDePagoServicio()
        {
            _tipoDePagoRepositorio = new TipoDePagoRepositorio();
        }

        public List<TipoDePago> GetTipoDePago()
        {
            return _tipoDePagoRepositorio.GetTipoDePago();
        }


        public bool Existe(TipoDePago tipoDePago)
        {
            return _tipoDePagoRepositorio.Existe(tipoDePago);
        }
        public void Guardar(TipoDePago tipoDePago)
        {
            if (tipoDePago.FormaDePagoId == 0)
            {
                _tipoDePagoRepositorio.Agregar(tipoDePago);
            }
            else
            {
                _tipoDePagoRepositorio.Editar(tipoDePago);
            }
        }
        public void Borrar(int tipoPagoId)
        {
            _tipoDePagoRepositorio.Borrar(tipoPagoId);
        }

        public List<TipoDePago> Filtrar(string textoParaFiltrar)
        {
            return _tipoDePagoRepositorio.Filtrar(textoParaFiltrar);
        }
    }
}
