using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class ParticleManager : Singleton<ParticleManager>
{
    public int _numParticles = 100;
    private List<Particle> _particles;
    private Attractor[] _atractors;
    public GameObject particlePrefab;

    void Start()
    {
        _particles = new List<Particle>();
        _atractors = FindObjectsOfType<Attractor>();
        for (int i = 0; i < _numParticles; i++)
        {
            GameObject go = Instantiate(particlePrefab, transform.position, transform.rotation, transform);
            Particle p = go.AddComponent<Particle>();
            _particles.Add(p);
        }
    }
    void Update()
    {
        for (int p = 0; p < _particles.Count; p++)
        {
            for (int a = 0; a < _atractors.Length; a++)
            {
                if (_atractors[a].isActive())
                {
                    _particles[p].Attract(_atractors[a]);
                }
            }

            _particles[p].Step();
        }
    }
}
