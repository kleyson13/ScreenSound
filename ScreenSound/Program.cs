Album albumDoParamore = new Album();
albumDoParamore.Nome = "All We Know Is Falling";

Musica musica1 = new Musica();
musica1.Nome = "Pressure";
musica1.Duracao = 186;

Musica musica2 = new Musica();
musica2.Nome = "Emergency";
musica2.Duracao = 179;

albumDoParamore.AdicionarMusica(musica1);
albumDoParamore.AdicionarMusica(musica2);

albumDoParamore.ExibirMusicasDoAlbum();