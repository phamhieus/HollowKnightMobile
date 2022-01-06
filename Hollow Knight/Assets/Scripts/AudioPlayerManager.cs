using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using UnityEngine;

namespace Assets.Scripts
{
  public class AudioPlayerManager : MonoBehaviour
  {
    private static AudioPlayerManager instance = null;
    private AudioSource audio;

    private void Awake()
    {
      if (instance == null)
      {
        instance = this;
        DontDestroyOnLoad(gameObject);
        return;
      }
      if (instance == this) return;
      Destroy(gameObject);
    }

    void Start()
    {
      audio = GetComponent<AudioSource>();
      audio.Play();
    }
  }
}
