using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEditor;
using UnityEngine;

public class ParticleManager : MonoBehaviour
{
    public int _numParticles = 100;
    private List<Particle> _particles;
    private Attractor[] _atractors;
    public GameObject particlePrefab;
    public float speed = 1.0f;
    public float gravity = 1.0f;

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
                if (_atractors[a].Active)
                {
                    _particles[p].Attract(_atractors[a]);
                }
            }

            _particles[p].Step(this);
        }
    }
}
