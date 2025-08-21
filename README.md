# 🐦 AR Bird Aerodynamics — Unity + Vuforia

An interactive **Augmented Reality (AR) app** built with **Unity (URP)** and **Vuforia**.  
The app anchors 3D bird models to real-world image targets and allows users to switch between them.  
A custom particle system with a virtual fan model simulates airflow, helping visualize aerodynamic forces like **lift, drag, and resistance** for each bird.

---

## ✨ Features
- Marker-based AR using 2D image targets  
- Multiple 3D bird models with switching support  
- Airflow simulation via particle systems  
- Visualization of aerodynamic forces (lift, drag, resistance)  
- Built on Unity URP for optimized rendering

---

## 🚀 Getting Started

### Prerequisites
- Unity 2021.x (or newer)  
- Vuforia Engine (installed via Unity Package Manager)  
- AR-capable mobile device (for testing builds)

### Setup
1. Clone this repo:

        git clone https://github.com/your-username/your-repo-name.git

2. Open the project in Unity Hub.  
3. Import Vuforia Engine via Window → Package Manager (or import your package).  
4. Add your Vuforia License Key under:  
   Edit → Project Settings → Vuforia Engine → App License Key  
5. Build & Run on an Android/iOS device.

---

## 📂 Project Structure
- Assets/Scenes/  → Main AR scenes  
- Assets/Models/  → 3D bird models  
- Assets/Scripts/ → Scripts for AR interaction and airflow simulation  
- .gitignore      → Unity auto-generated folders excluded

---

## 🙌 Contribution
Pull requests are welcome! If you’d like to add more bird models or new aerodynamic visualizations, feel free to fork the repo.

---

## 📜 License
MIT License — see the LICENSE file for details.
