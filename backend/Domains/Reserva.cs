﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace backend.Domains
{
    public partial class Reserva
    {
        [Key]
        [Column("id_reserva")]
        public int IdReserva { get; set; }
        [Column("id_oferta")]
        public int? IdOferta { get; set; }
        [Column("id_usuario")]
        public int? IdUsuario { get; set; }
        [Column("quantidade_reserva")]
        public int QuantidadeReserva { get; set; }
        [Column("cronometro", TypeName = "time(3)")]
        public TimeSpan Cronometro { get; set; }
        [Column("status_reserva")]
        public bool StatusReserva { get; set; }

        [ForeignKey(nameof(IdOferta))]
        [InverseProperty(nameof(Oferta.Reserva))]
        public virtual Oferta IdOfertaNavigation { get; set; }
        [ForeignKey(nameof(IdUsuario))]
        [InverseProperty(nameof(Usuario.Reserva))]
        public virtual Usuario IdUsuarioNavigation { get; set; }
    }
}
