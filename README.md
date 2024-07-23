# Reconcilor
Reconcilor is designed to store and report production data from mine to mill.

# Definations

# 💫 About Me:
A shaft is an underground mine. <br>A stope: refers to a block located at the shaft where estimates of ore Tonnes, TCo, TCu, Cu, and Co have been made. 
<br>Ore: is pre-processed rock that contains trace amounts of valuable cobalt and copper. <br>Tonnes: The amount of ore in a stope that is received at the mill (RMD) or travels along a conveyor belt (Belt). <br>TCu: The valuable Cu percentage in the stope that goes through the RMD, or belt. Since it is a percentage, only numbers between 0 and 100 are allowed. <br>TCo: is the valuable coal percentage in the stope that goes through the RMD or Belt. Since it is a percentage, only numbers between 0 and 100 are allowed.<br>Cu: The actual amount of copper in the stope that travels via the belt or RMD. The calculation is done directly by dividing (TCu / 100). * Tonnes <br>Co: The actual amount of cobalt that enters the Stope and travels via the Belt or RMD. The calculation is done directly by dividing (TCo / 100) * Tonnes. <br>Belt: From the shaft, a conveyor belt Developed: <br>A tunnel: beneath the surface <br>Model: A digital approximation of TCu, TCo, and stope tonnes <br>Shift: The list from the Common Properties class has three components: morning, afternoon, and night.

# 📊 GitHub Stats:


# Formular
** Dry Tonnes = Wet Tonnes - ((Moisture/100)* Wet Tonnes)
** TCu = (ContainedCu/Tonnes) * 100
** TCo = (ContainedCu/Tonnes) * 100
** Cu = (TCu/100) * Tonnes;
** Co = (TCo/100) * Tonnes;
