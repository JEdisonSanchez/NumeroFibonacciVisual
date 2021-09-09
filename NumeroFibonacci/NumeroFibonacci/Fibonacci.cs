﻿namespace NumeroFibonacci
{
    using System;
    class Fibonacci
    {
        private int numeroParaCalcular;
        private int numeroResultante;

        public Fibonacci(int numeroParaCalcular)
        {
            this.numeroParaCalcular = numeroParaCalcular;
        }

        public int getNumeroParaCalcular()
        {
            return numeroParaCalcular;
        }

        public void setNumeroParaCalcular(int numeroParaCalcular)
        {
            this.numeroParaCalcular = numeroParaCalcular;
        }

        public int getNumeroResultante()
        {
            return numeroResultante;
        }

        public void setNumeroResultante(int numeroResultante)
        {
            this.numeroResultante = numeroResultante;
        }

        /// <summary>
        /// Método que permiter mostrar la serie Fibonacci del numero ingresado
        /// </summary>
        public void imprimirSerieFibonacci()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("La serie fibonacci para el numero " + this.numeroParaCalcular + " es: ");
            for (int i = 0; i <= this.numeroParaCalcular; i++)
            {
                Console.Write(this.calcularFibonacci(i) + "  ");
                this.numeroResultante = this.calcularFibonacci(i);
            }
            Console.WriteLine();
            Console.WriteLine("-----------------------");
        }

        /// <summary>
        /// Método que permiter mostrar si el ultimo número de la serie es primo
        /// </summary>
        public void imprimirPrimo()
        {
            if (this.esPrimo(this.numeroResultante))
            {
                Console.WriteLine(this.numeroResultante + " es primo");
            }
            else
            {
                Console.WriteLine(this.numeroResultante + " no es primo");
            }
        }

        /// <summary>
        /// Metodo que al enviarle por parametro un número, nos devuelve un valor
        /// boolean el cual indica si es primo(true) o no es primo(false)
        /// </summary>
        private bool esPrimo(int numero)
        {
            int contador = 0;
            bool esPrimo = false;
            for (int i = 1; i <= numero; i++)
            {
                if (numero % i == 0)
                {
                    contador += 1;
                }
            }
            if (contador == 2)
            {
                esPrimo = true;
            }
            return esPrimo;
        }

        /// <summary>
        /// Metodo que al enviarle por parametro un número, nos devuelve el 
        /// siguiente número de la serie fibonacci
        /// </summary>
        private int calcularFibonacci(int numero)
        {
            switch (numero)
            {
                case 0:
                    return 0;
                case 1:
                    return 1;
                default:
                    return this.calcularFibonacci(numero - 1) + this.calcularFibonacci(numero - 2);
            }
        }

    }
}
