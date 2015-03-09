﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] m_Enemies;
    public Text m_WaveText;
    public Text m_ReqKillText;

    public float m_SpawnDelay;
    public float m_StartDelay;
    public float m_WaveDelay;

    public int m_RequiredKills;
    public int m_WaveNum;

    public List<GameObject> enemyPool_ = new List<GameObject>();

    public Vector3 m_SpawnArea;

    public void AISpawn()
    {

        if (m_WaveNum == 0)
        {
            m_WaveNum++;
            m_WaveText.text = m_WaveNum.ToString("F0");

            m_RequiredKills = 10;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            //populate enemy array
            for (int e = 0; e < m_Enemies.Length - 2; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 1)
        {
            //populate enemy array
            m_RequiredKills = 10;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length - 2; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }
            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 2)
        {
            //populate enemy array
            m_RequiredKills = 15;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length - 2; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 3)
        {
            //populate enemy array
            m_RequiredKills = 20;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length - 1; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 4)
        {
            //populate enemy array
            m_RequiredKills = 25;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length - 1; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }
            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 5)
        {
            //populate enemy array
            /*m_RequiredKills = 10;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }*/

            //set MiniBoss to spawn
            SpawnMiniBoss();


            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 6)
        {
            //populate enemy array
            m_RequiredKills = 30;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 7)
        {
            //populate enemy array
            m_RequiredKills = 35;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 8)
        {
            //populate enemy array
            m_RequiredKills = 40;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 9)
        {
            //populate enemy array
            m_RequiredKills = 45;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }

            //Set Boss to Spawn
            SpawnBoss();
            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }

        if (m_WaveNum == 10)
        {
            //populate enemy array
            /*m_RequiredKills = 45;
            m_ReqKillText.text = m_RequiredKills.ToString("F0");

            for (int e = 0; e < m_Enemies.Length; e++)
            {
                for (int i = 0; i < m_RequiredKills; i++)
                {
                    GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                    obj.SetActive(false);
                    enemyPool_.Add(obj);
                }
            }*/

            //Set Boss to Spawn
            SpawnBoss();
            //if play is active start spawning
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                StartCoroutine(Camera.main.GetComponent<Waves>().WaveSpawner());
            }
            //else do nothing
            else
            {
                return;
            }
        }
    }

    public void SpawnBoss()
    {
        Debug.Log("Time to code that MiniBoss guys!");
        for (int e = 0; e < m_Enemies.Length; e++)
        {
            for (int i = 0; i < m_RequiredKills; i++)
            {
                GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                obj.SetActive(false);
                enemyPool_.Add(obj);
            }
        }
    }

    public void SpawnMiniBoss()
    {
        Debug.Log("Time to code that Boss guys!");
        for (int e = 0; e < m_Enemies.Length; e++)
        {
            for (int i = 0; i < m_RequiredKills; i++)
            {
                GameObject obj = (GameObject)Instantiate(m_Enemies[e]);
                obj.SetActive(false);
                enemyPool_.Add(obj);
            }
        }
    }

    /*IEnumerator WaveSpawner()
    {
        yield return new WaitForSeconds(m_StartDelay);



        while (m_RequiredKills > 0 && GameObject.FindGameObjectWithTag("Player") != null)
        {
            for (int i = 0; i < m_RequiredKills; ++i)
            {
                Vector3 spawnPosition = new Vector3(Random.Range(-m_SpawnArea.x, m_SpawnArea.x), m_SpawnArea.y, m_SpawnArea.z);
                Quaternion spawnRotation = Quaternion.identity;

                for (int j = 0; j < enemyPool_.Count; ++j)
                {
                    enemyPool_[i].SetActive(true);
                    enemyPool_[i].transform.position = spawnPosition;
                    enemyPool_[i].transform.rotation = spawnRotation;
                }
                yield return new WaitForSeconds(m_SpawnDelay);
            }
            yield return new WaitForSeconds(m_WaveDelay);

            if (m_RequiredKills == 0)
            {
                m_WaveNum++;
                m_WaveText.text = m_WaveNum.ToString("F0");
                AISpawn();
            }

            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                Camera.main.GetComponent<GameController>().Load();
            }

            if (Camera.main.GetComponent<GameController>().gameOver_)
            {
                Camera.main.GetComponent<GameController>().restart_ = true;
                Camera.main.GetComponent<GameController>().GameOver();
                break;
            }
        }
    }*/
}
