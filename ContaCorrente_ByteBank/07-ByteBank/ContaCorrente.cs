﻿using _07_ByteBank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_ByteBank
{
    public class ContaCorrente
    {

        public static double TaxaOperacao { get; private set; }
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }

        public int Agencia { get; } //quando não declara o get ele automaticamente vira um readonly
        public int Numero { get; }

        private double _saldo = 100;
        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _saldo = value;
            }
        }


        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("A agência deve ser maior que 0.", nameof(agencia));//após a vírgula é colocado o ParamName
            }
            if (numero <= 0)
            {
                throw new ArgumentException("O numero deve ser maior que 0.", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;

            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }

        public void Sacar(double valor)
        {
            if(valor < 0)
            {
                throw new ArgumentException("Valor inválido para o saque. ", nameof(valor));
            }

            if (_saldo < valor)
            {
                throw new SaldoInsuficienteException(Saldo, valor);
            }
            else
            {
                this._saldo -= valor;

            }
        }

         public void Depositar(double valor)
         {
             _saldo += valor;
         }

         public void Transferir(double valor, ContaCorrente contaDestino)
         {
            if (valor < 0)
            {
                throw new ArgumentException("Valor inválido para a transferência. ", nameof(valor));
            }

            Sacar(valor);
            contaDestino.Depositar(valor);
             
         }




    }
} 


