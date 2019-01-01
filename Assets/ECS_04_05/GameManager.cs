using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using Unity.Jobs;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;
using UnityEngine.Jobs;

namespace ECS_04{

	public class GameManager : MonoBehaviour {

		public static GameManager GM;

		[Header("Simunlation Settings")]
		public float topBound = 16.5f;
		public float bottomBound = -13.5f;
		public float leftBound = -23.5f;
		public float rightBound = 23.5f;


		[Header("Enemy Settings")]
		public GameObject enemyShipPrefab;
		public float enemySpeed = 1f;


		[Header("Spawn Settings")]
		public int enemyShipCount = 1;
		public int enemyShipIncrement = 1;

		//FPS fps;
		public int count;

		void Awake(){
			if(GM == null)
				GM = this;
			else if(GM != this)
				Destroy(gameObject);
			
			DontDestroyOnLoad(gameObject);

		}

		EntityManager manager;

		void Start()
		{
			manager = World.Active.GetOrCreateManager<EntityManager>();
			AddShips(enemyShipCount);		
		}

		void Update () {
			if(Input.GetKeyDown("space")){
				AddShips(enemyShipIncrement);
			}
		}

		void AddShips(int amount){
			NativeArray<Entity> entities = new NativeArray<Entity>(amount, Allocator.Temp);
			manager.Instantiate(enemyShipPrefab, entities);

			for(int i=0; i<amount; i++)
			{
				float xVal = Random.Range(leftBound, rightBound);
				float zVal = Random.Range(0f,10f);
				manager.SetComponentData(entities[i], new Position { Value = new float3(xVal, 0f, topBound + zVal) });
				manager.SetComponentData(entities[i], new Rotation { Value = new quaternion(0,1,0,0) });
				manager.SetComponentData(entities[i], new MoveSpeed { Value = enemySpeed });

			}
			entities.Dispose();

			count += amount;


		}



		/* -------- EXAMPLE 2 -----------
		 TransformAccessArray transforms;
		MovementJob moveJob;
		JobHandle moveHandle;

		void OnDisable(){
			moveHandle.Complete();
			transforms.Dispose();
		}

		void Start(){
			transforms = new TransformAccessArray(0,-1);

			AddShips(enemyShipCount);
		}

		void Update()
		{
			moveHandle.Complete();

			if(Input.GetKeyDown("space")){
				AddShips(enemyShipIncrement);
			}

			moveJob = new MovementJob()
			{
				moveSpeed = enemySpeed,
				topBound = topBound,
				bottomBound = bottomBound,
				deltaTime = Time.deltaTime
			};

			moveHandle = moveJob.Schedule(transforms);

			JobHandle.ScheduleBatchedJobs();

		}

		void AddShips(int amount)
		{
			moveHandle.Complete();

			transforms.capacity = transforms.length + amount;

		

			for(int i = 0; i < amount; i++){
				float xVal = Random.Range(leftBound, rightBound);
				float zVal = Random.Range(0,10f);

				Vector3 pos = new Vector3(xVal, 0, zVal+topBound);
				Quaternion rot = Quaternion.Euler(0f,180f,0f);

				var obj = Instantiate(enemyShipPrefab, pos, rot) as GameObject;
			
				transforms.Add(obj.transform);
			}
			count += amount; 
			
			//fps.SetElementCount(count);
		} */


		/* --------- EXAMPLE 1 --------------
		
		// Use this for initialization
		void Start () {
			//fps = GetComponent<FPS>();
			AddShips(enemyShipCount);
		}
		
		// Update is called once per frame
		void Update () {
			if(Input.GetKeyDown("space")){
				AddShips(enemyShipIncrement);
			}
		}

		void AddShips(int amount){
			for(int i = 0; i < amount; i++){
				float xVal = Random.Range(leftBound, rightBound);
				float zVal = Random.Range(0,10f);

				Vector3 pos = new Vector3(xVal, 0, zVal+topBound);
				Quaternion rot = Quaternion.Euler(0f,180f,0f);

				var obj = Instantiate(enemyShipPrefab, pos, rot) as GameObject;
			}

			count += amount;
			//fps.SetElementCount(count);
		} */
	}

}