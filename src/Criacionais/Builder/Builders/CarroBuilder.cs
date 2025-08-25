using Builder.Models;

namespace Builder.Builders
{
    public class CarroBuilder
    {
        private Carro _carro = new Carro();

        public CarroBuilder Motor(string motor)
        {
            _carro.Motor = motor;
            return this;
        }

        public CarroBuilder Cor(string cor)
        {
            _carro.Cor = cor;
            return this;
        }

        public CarroBuilder Portas(int portas)
        {
            _carro.Portas = portas;
            return this;
        }

        public CarroBuilder ComArCondicionado()
        {
            _carro.TemArCondicionado = true;
            return this;
        }

        public CarroBuilder SemArCondicionado()
        {
            _carro.TemArCondicionado = false;
            return this;
        }

        public CarroBuilder ComTetoSolar()
        {
            _carro.TemTetoSolar = true;
            return this;
        }

        public CarroBuilder SemTetoSolar()
        {
            _carro.TemTetoSolar = false;
            return this;
        }

        public CarroBuilder ComSistemaDeSom()
        {
            _carro.SistemaDeSom = true;
            return this;
        }

        public CarroBuilder SemSistemaDeSom()
        {
            _carro.SistemaDeSom = false;
            return this;
        }

        public Carro Build()
        {
            return _carro;
        }
    }
}
