using System;

namespace PoleUtil
{
    public class Pole
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        static public int[] Vymena(int[] pole, int max)
        {
            int maxpozice = 0;
            int posledni = 0;
            int kybl;

            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] > max)
                {
                    max = pole[i];
                    maxpozice = i;
                }

            }
            kybl = pole[pole.Length - 1];
            pole[pole.Length - 1] = pole[maxpozice];
            pole[maxpozice] = kybl;
            return pole;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        /// <returns></returns>
        static public bool Rostouci(int[] pole)
        {

            for (int i = 1; i < pole.Length; i++)
            {
                if (pole[i] < pole[i - 1])
                {
                    return false;
                }

            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pole"></param>
        /// <param name="soucetsudych"></param>
        /// <param name="pocetlichych"></param>
        static public void Sudaalichacisla(int[] pole, out int soucetsudych, out int pocetlichych)
        {
            soucetsudych = 0;
            pocetlichych = 0;
            for (int i = 0; i < pole.Length; i++)
            {
                if (pole[i] % 2 == 0)
                {
                    soucetsudych += pole[i];

                }
                else
                {
                    pocetlichych++;
                }
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="dabel"></param>
        /// <param name="pole"></param>
        static public string Vypis(int[] pole)
        {
            string text = string.Empty;
            for (int i = 0; i < pole.Length; i++)
            {
                text += pole[i];
                text = Environment.NewLine;
            }
            return text;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pocetprvku"></param>
        /// <param name="dolni"></param>
        /// <param name="horni"></param>
        /// <returns></returns>
        static public int[] Generuj(int pocetprvku, int dolni = 1, int horni = 100)
        {
            int[] pole = new int[pocetprvku];
            Random rnd = new Random();
            for (int i = 0; i < pocetprvku; i++)
            {
                pole[i] = rnd.Next(dolni, horni + 1);
            }
            return pole;
        }
    }
}

    
