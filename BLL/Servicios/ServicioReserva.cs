﻿using DAL.BaseDatos;
using DAL.Repositorios;
using ENTITY.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLL.Servicios
{
    public class ServicioReserva
    {
        private readonly RepositorioReserva repositorioReserva;
        private readonly RepositorioCliente repositorioCliente;

        //private readonly BDRepositorioReserva repositorioReserva;
       // private readonly BDRepositorioCliente repositorioCliente;
        public ServicioReserva()
        {
            repositorioReserva = new RepositorioReserva();
            repositorioCliente = new RepositorioCliente();
           
        }

        public string Crear(Reserva reserva)
        {
            try
            {
                if (reserva.cliente == null)
                {
                    return "No se puede realizar la reserva, debido a que NO existe un cliente con esta identificacion";
                }
                else if (ValidarFecha(reserva))
                {
                    return "No se pudo realizar la reserva, devido a que esta fecha ya paso";
                }
                
                else if (EsHorarioDisponible(reserva.fecha, reserva.horaInicio,reserva.horaFin))
                {
                    repositorioReserva.Crear(reserva);
                    return "Reserva realizada con exito";
                }
                else
                {
                    return "No se pudo realizar la reserva por el horario";
                 }
                
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al crear la reserva: {ex.Message}");
                return "No se pudo";
            }
        }
        public Reserva buscarReserva(int idReserva)
        {
            return repositorioReserva.buscarReserva(idReserva);
        }

        public string Modificar(Reserva reserva)
        {
            if (repositorioReserva.Modificar(reserva))
            {
                return "Estado modificado";
            }
            else
                return "Error al modificar el estado";
        }
        public List<Reserva> listaReservas()
        {
            return repositorioReserva.listaReservas();
        }

        public List<Reserva> FiltroTipoEvento(string TipoEvento)
        {
            List<Reserva> filtrado = new List<Reserva>();
            foreach (Reserva reserva in listaReservas())
            {
                if (reserva.tipoEvento == TipoEvento)
                {
                    filtrado.Add(reserva);
                }
            }
            return filtrado;
        }

        public List<Reserva> FiltroPorEstado(string Estado)
        {
            List<Reserva> filtrado = new List<Reserva>();
            foreach (Reserva reserva in listaReservas())
            {
                if (reserva.estado == Estado)
                {
                    filtrado.Add(reserva);
                }
            }
            return filtrado;
        }

        public int idReserva()
        {
            int id = 0;
            List<Reserva> lista = listaReservas();
            Reserva reserva = lista[lista.Count - 1];
            
            return reserva.idReserva+1;
        }

        public int ReservasMes()
        {
            DateTime date = DateTime.Now;
            int Mes, Año;
            

            Mes = date.Month;
            Año = date.Year;

            var reservasProgramadas = listaReservas().Where(reserva => reserva.fecha.Month == Mes &&
            reserva.fecha.Year == Año
            );

            return reservasProgramadas.Count();
        }

        private bool ValidarFecha(Reserva reserva)
        {
            if (reserva.fecha < DateTime.Now)
            {
                return true;
            }
            return false;
        }

        public bool EsHorarioDisponible(DateTime fecha, TimeSpan horaInicio, TimeSpan horaFin)
        {
            List<Reserva> reservas = new List<Reserva>();
            reservas = listaReservas();
     
            return !reservas.Any(r =>
                r.fecha.Date == fecha.Date &&
                (horaInicio >= r.horaInicio && horaInicio < r.horaFin) ||
                (horaFin > r.horaInicio && horaFin <= r.horaFin));
        }
    }
}
