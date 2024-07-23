# Reconcilor
Reconcilor is designed to store and report production data from mine to mill.

# 💫 Definations:
- A shaft is an underground mine.
- A stope: refers to a block located at the shaft where estimates of ore Tonnes, TCo, TCu, Cu, and Co have been made. 
- Ore: is pre-processed rock that contains trace amounts of valuable cobalt and copper.
- Tonnes: The amount of ore in a stope that is received at the mill (RMD) or travels along a conveyor belt (Belt).
- TCu: The valuable Cu percentage in the stope that goes through the RMD, or belt. Numbers between 0 and 100 are allowed.
- TCo: is the valuable coal percentage in the stope that goes through the RMD or Belt. Numbers between 0 and 100 are allowed.
- Cu: The actual amount of copper in the stope that travels via the belt or RMD. * Tonnes
- Co: The actual amount of cobalt that enters the Stope and travels via the Belt or RMD.
- Belt: From the shaft, a conveyor belt
- Developed: A tunnel beneath the surface
- Model: A digital approximation of TCu, TCo, and stope tonnes
- Shift: The list from the Common Properties class has three components: morning, afternoon, and night.

# 📊 Formulars:

- Dry Tonnes = Wet Tonnes - ((Moisture/100)* Wet Tonnes)
- TCu = (ContainedCu/Tonnes) * 100
- TCo = (ContainedCu/Tonnes) * 100
- Cu = (TCu/100) * Tonnes;
- Co = (TCo/100) * Tonnes;
