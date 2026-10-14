import keyboard
import os

keyboard.add_hotkey("ctrl+alt+p", lambda: os.startfile(r"C:\Program Files\ShareX\ShareX.exe"))

print("Atalho ativo!")

keyboard.wait()