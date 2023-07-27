Banda paramore = new Banda("Paramore");

Album albumDoParamore = new Album("All We Know Is Falling");

Musica musica1 = new Musica(paramore, "Pressure")
{
    Duracao = 186,
    Disponivel = true,
};


Musica musica2 = new Musica(paramore, "Emergency")
{
    Duracao = 179,
    Disponivel = false,
};


albumDoParamore.AdicionarMusica(musica1);
albumDoParamore.AdicionarMusica(musica2);
paramore.AdicionarAlbum(albumDoParamore);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
albumDoParamore.ExibirMusicasDoAlbum();
paramore.ExibirDiscografia();
