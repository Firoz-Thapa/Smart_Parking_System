# Smart Parking System 🚗🅿️

A fun 3D parking game made with Unity! Watch cars drive around, open gates automatically, and park themselves on a rotating lift.

## What does this project do? 🎯

This is a simple parking simulation where:
- 🚙 **Cars spawn** when you click a button
- 🚪 **Gates open automatically** when cars get close
- 🔄 **Parking lift rotates** to park cars on different levels
- 📹 **Camera follows** the newest car around

Perfect for learning Unity basics like collisions, animations, and object spawning!

## How to play 🎮

1. Press the **Spawn Car** button
2. Watch the car drive toward the gate
3. See the gate open automatically
4. Car drives onto the parking lift
5. Lift rotates and parks the car!

## What you need 📋

- **Unity 2022.3.8f1** (or newer)
- Basic knowledge of Unity (helpful but not required!)

## How to run this project 🚀

### Step 1: Get the code
```bash
git clone https://github.com/Firoz-Thapa/Smart_Parking_System.git
```

### Step 2: Open in Unity
1. Open **Unity Hub**
2. Click **"Add"** or **"Open"**
3. Choose the downloaded folder
4. Wait for Unity to load everything

### Step 3: Play!
1. Open the **SampleScene** in the Scenes folder
2. Click the **Play** button (▶️)
3. Click spawn buttons to create cars

## How it works (Simple explanation) 🔧

### The Main Scripts

**Spawner.cs** - Creates new cars
```csharp
// When you click the button, this makes a new car appear
public void OnButtonClick()
```

**Door.cs** - Opens gates when cars come near
```csharp
// When a car touches the gate area, the gate opens
private void OnTriggerEnter(Collider other)
```

**FloorCollision.cs** - Handles parking
```csharp
// When a car reaches the parking spot, it gets parked
void OnTriggerEnter(Collider other)
```

**CollisionHandler.cs** - Controls the parking lift
```csharp
// Starts and stops the parking lift animation
public void TogglePause()
```

### How cars change as they move:
1. **"Not Detected Car"** → Just spawned
2. **"Gate Detected Car"** → Near a gate  
3. **"Parked Car"** → Successfully parked

## Project folders 📁

```
Assets/
├── Scripts/           ← All the code files
├── Prefab/           ← Ready-made objects (cars, gates, etc.)
├── Scenes/           ← The game level
└── Animations/       ← Moving parts (gates, lifts)
```
