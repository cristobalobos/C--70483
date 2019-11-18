namespace Orquesta
{
    /// <summary>
    /// Primer nivel de herencia
    /// </summary>
    public abstract class Cuerda : Instrumento {
        public override void Afinar() {Afinando = true;}
        public Cuerda(string nombre) : base(nombre) { }
    }
    /// <summary>
    ///  Segundo nivel de herencia
    /// </summary>
    public abstract class ConArco : Cuerda { public ConArco(string nombre) : base(nombre) { } }
    public abstract class SinArco : Cuerda { public SinArco(string nombre) : base(nombre) { } }
    /// <summary>
    ///  Tercer nivel de herencia
    /// </summary>
    public class Cello : ConArco, ITransportar { 
        public Cello(string nombre) : base(nombre) { Situado = false; }
        public void Transportar() { Situado = true; }
    }
    public class Violin : ConArco { public Violin(string nombre) : base(nombre) { } }
    public class Contrabajo : SinArco, ITransportar {
        public Contrabajo(string nombre) : base(nombre) { Situado = false; }
        public void Transportar() { Situado = true; }
    }
    public class Guitarra : SinArco { public Guitarra(string nombre) : base(nombre) { } }
}
