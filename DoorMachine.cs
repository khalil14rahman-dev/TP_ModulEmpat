using System;
using System.Collections.Generic;
using System.Text;

namespace TP_ModulEmpat
{
    public class DoorMachine
    {
        // Definisi state yang tersedia berdasarkan diagram 
        public enum State { Terkunci, Terbuka };

        // Variabel untuk menyimpan state saat ini
        public State currentState;

        public DoorMachine()
        {
            // Asumsi state awal adalah terkunci  
            currentState = State.Terkunci;
            Console.WriteLine("Pintu terkunci"); 
        }

        // Method untuk mensimulasikan perubahan state 
        public void PerubahanState(string perintah)
        {
            if (currentState == State.Terkunci && perintah == "BukaPintu")
            {
                currentState = State.Terbuka;
                Console.WriteLine("Pintu tidak terkunci"); 
            }
            else if (currentState == State.Terbuka && perintah == "KunciPintu")
            {
                currentState = State.Terkunci;
                Console.WriteLine("Pintu terkunci"); 
            }
        }
    }
}
