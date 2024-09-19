public class ContaBancaria{

    public string titular;
    public int saldo;

    public string agencia;

    public ContaBancaria(string titular, int saldo, string agencia){
        this.titular = titular;
        this.saldo = saldo;
        this.agencia = agencia;
    }
    public void Mostrarinfo(){
        Console.WriteLine("O titular: {0}\nTem saldo disponivel: {1}\nNa agência: {2}", titular, saldo, agencia);
    }
}