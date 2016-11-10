using UnityEngine;

namespace MarlonLuan.MLFramework.Unity.Scripts
{
    public static class BancoDeDados
    {
        public static void Save(string nome, int idade)
        {
            User u = new User();
            u.ID = 1;
            u.Nome = nome;
            u.Idade = idade;

            PlayerPrefs.SetString("nome", u.Nome);
            PlayerPrefs.SetInt("idade", u.Idade);
        }

        public static User Load()
        {
            User u = new User();
            u.Nome = PlayerPrefs.GetString("nome", u.Nome);
            u.Idade = PlayerPrefs.GetInt("idade", u.Idade);

            return u;
        }
    }
}