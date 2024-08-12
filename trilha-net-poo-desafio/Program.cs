using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone

Nokia nk = new Nokia("9999-8888", "NOK-897", "789456QWE1234", 128);
nk.InstalarAplicativo("LigarViaWeb");
nk.Ligar();

Iphone iph = new Iphone("9999-7777", "IPH-145", "562415TYUB15987", 512);
iph.InstalarAplicativo("LigarViaWeb");
iph.ReceberLigacao();