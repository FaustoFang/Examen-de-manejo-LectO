﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// using LiteDB;

namespace Examen_de_manejo_LectO
{

    public class Pregunta
    {
        public int id { get; set; }
        public string txtPregunta { get; set; }
        public string imagen { get; set; }
        public string respuestaCorrecta { get; set; }
        public string opcion1 { get; set; }
        public string opcion2 { get; set; }
    }

    public class Opcion
    {
        public string texto { get; set; }
        public bool esCorrecto { get; set; }
    }

    public class Examen
    {
        public string titulo { get; set; }
        public List<Pregunta> preguntas { get; set; }
    }

    public class DB
    {
        public List<Examen> examenes { get; set; }
    }

    public class PreguntaRandomizada
    {
        public string pregunta { get; set; }
        public List<Opcion> opciones { get; set; }
        public string imagen { get; set; }
        public int respondido { get; set; }

        public PreguntaRandomizada()
        {
            respondido = -1;
        }
    }

    [Serializable]
    public class Resultado
    {
        public string numeroDocumento { get; set; }
        public string nombre { get; set; }
        public int aciertos { get; set; }
        public int totalPreguntas { get; set; }
        public List<PreguntaRandomizada> preguntas { get; set; }
    }


    public static class Shuffle
    {
        private static Random random = new Random();

        public static void List<T> (ref List<T> lista)
        {
            int n = lista.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                T value = lista[k];
                lista[k] = lista[n];
                lista[n] = value;
            }
        }
    }
}
