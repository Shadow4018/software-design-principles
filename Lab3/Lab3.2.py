import re
import tkinter as tk
from tkinter import messagebox, simpledialog

# Функція для пошуку скорочень у тексті
def find_abbreviations(text):
    # Шукаємо слова, що закінчуються на крапку
    pattern = r'\b\w+\.'  
    return re.findall(pattern, text)

# Функція для відображення результатів
def show_results():
    global abbreviations
    text = text_input.get("1.0", tk.END)
    abbreviations = find_abbreviations(text)
    result_list.delete(0, tk.END)
    for abbr in abbreviations:
        result_list.insert(tk.END, abbr)
    count_label.config(text=f"Кількість скорочень: {len(abbreviations)}")

# Функція для видалення вибраного скорочення
def delete_abbreviation():
    global abbreviations
    selected = result_list.curselection()
    if selected:
        abbr = result_list.get(selected)
        text = text_input.get("1.0", tk.END)
        # Видаляємо всі входження скорочення
        text = text.replace(abbr, "")
        text_input.delete("1.0", tk.END)
        text_input.insert(tk.END, text)
        show_results()
    else:
        messagebox.showwarning("Увага", "Виберіть скорочення для видалення!")

# Функція для заміни вибраного скорочення
def replace_abbreviation():
    global abbreviations
    selected = result_list.curselection()
    if selected:
        abbr = result_list.get(selected)
        replacement = simpledialog.askstring("Заміна", f"Введіть заміну для {abbr}:")
        if replacement is not None:
            text = text_input.get("1.0", tk.END)
            text = text.replace(abbr, replacement)
            text_input.delete("1.0", tk.END)
            text_input.insert(tk.END, text)
            show_results()
    else:
        messagebox.showwarning("Увага", "Виберіть скорочення для заміни!")

# GUI
root = tk.Tk()
root.title("Пошук скорочень у тексті")

tk.Label(root, text="Введіть текст:").pack()
text_input = tk.Text(root, height=10, width=60)
text_input.pack()

tk.Button(root, text="Знайти скорочення", command=show_results).pack(pady=5)

count_label = tk.Label(root, text="Кількість скорочень: 0")
count_label.pack()

tk.Label(root, text="Список скорочень:").pack()
result_list = tk.Listbox(root, width=30)
result_list.pack()

btn_frame = tk.Frame(root)
btn_frame.pack(pady=5)

tk.Button(btn_frame, text="Видалити", command=delete_abbreviation).grid(row=0, column=0, padx=5)
tk.Button(btn_frame, text="Замінити", command=replace_abbreviation).grid(row=0, column=1, padx=5)

root.mainloop()
