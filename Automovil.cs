namespace TareaPoo;
class Automovil
{
    public string id;
    public string Marca;
    public int KM;
    public double Precio;
    public string Modelo;

    public override string ToString()
    {
        return $"id: {this.id}, Marca: {this.Marca}, Modelo: {this.Modelo}, Km: {this.KM}, Precio: {this.Precio}";
    }
    
}


