using UnityEngine;
using System.Collections;
using MLFramework_Views = MarlonLuan.MLFramework.Unity.Scripts.Views.Cenas;
using System;

namespace MarlonLuan.MLFramework.Unity.Scripts.Models
{
    public class ItemFormMModel
    {
        public string[] LabelTextField { get; set; }
        public int TamanhoTextField { get; set; }
        public bool isObrigatorio { get; set; }
        public string TextObrigatorio { get; set; }
        public string Dica { get; set; }

        public Rect[] FundoItem { get; set; }
    }
}