﻿namespace tpAgencia_Gpo_2
{
    public class Usuario
    {
        public int id { get; set; }
        public string name { get; set; }
        public string apellido { get; set; }
        public int dni { get; set; }
        public string mail { get; set; }
        public string password { get; set; }
        public int intentosFallidos { get; set; }
        public Boolean bloqueado { get; set; }
        private List<ReservaHotel> misReservasHoteles {  get; set; }
        private List<ReservaVuelo> misReservasVuelo { get; set; }

        public Double credito { get; set; }
        public Boolean esAdmin {  get; set; }
        private List<Hotel> hotelesVisitados { get; set; }
        private List<Vuelo> vuelosTomados { get; set; }

        //constructres
        public Usuario()
        {
        }

        public Usuario(int id, string name, string apellido, int dni,string mail,string password, bool esAdmin)
        {
            this.id = id;
            this.name = name;
            this.apellido = apellido;
            this.dni = dni;
            this.mail = mail;  
            this.password = password;   
            this.esAdmin = false;
        }

        //metodos

        public void agregarIntentoFallido()
        {
            intentosFallidos++;
            if (intentosFallidos >= 3)
            {
                bloqueado = true;
            }
        }
    }
}