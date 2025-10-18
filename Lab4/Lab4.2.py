import tkinter as tk
from tkinter import scrolledtext, filedialog, messagebox
from random import*
import random
import string

def tf1():
    file_path = r"D:\projects\GitHub\software-design-principles\Lab4\TF1.txt"
    try:
        with open(file_path, 'w', encoding='utf-8') as file:
            lines = randint(3, 8) 

            for _ in range(lines):
                words_in_line = randint(5, 10)
                line_words = []

                for _ in range(words_in_line):
                    word_length = randint(3, 8)
                    if randint(1, 100) <= 30:
                        base = [choice(string.ascii_lowercase) for _ in range(word_length - 1)]
                        pos = randint(1, len(base) - 1)
                        base.insert(pos, base[pos - 1])
                        word = ''.join(base)
                    else:
                        word = ''.join(choice(string.ascii_lowercase) for _ in range(word_length))
                    
                    line_words.append(word)

                file.write(' '.join(line_words) + '\n')

        messagebox.showinfo("Успіх", f"Файл створено: {file_path}")
        status_var.set(f"Файл створено: {file_path}")

    except Exception as e:
        messagebox.showerror("Помилка", f"Не вдалося створити файл: {e}")
        status_var.set("Помилка при створенні файлу")

def find_doubles():
    input_path = r"D:\projects\GitHub\software-design-principles\Lab4\TF1.txt"
    output_path = r"D:\projects\GitHub\software-design-principles\Lab4\TF2.txt"
    try:
        with open(input_path, 'r', encoding='utf-8') as infile, open(output_path, 'w', encoding='utf-8') as outfile:
            lines = infile.readlines()
            found_words = set()

            for line in lines:
                words = line.split()
                for word in words:
                    for i in range(1, len(word)):
                        if word[i] == word[i - 1]:
                            found_words.add(word)
                            break

            if found_words:
                outfile.write('\n'.join(found_words))
                messagebox.showinfo("Успіх", f"Знайдено {len(found_words)} слів з подвоєннями. Результат у TF_2.")
                status_var.set(f"Знайдено {len(found_words)} слів з подвоєннями.")
            else:
                outfile.write("Слів з подвоєннями не знайдено.")
                messagebox.showinfo("Результат", "Слів з подвоєннями не знайдено.")
                status_var.set("Слів з подвоєннями не знайдено.")

    except Exception as e:
        messagebox.showerror("Помилка", f"Не вдалося обробити файл: {e}")
        status_var.set("Помилка при обробці файлу")

def show_tf2():
    output_path = r"D:\projects\GitHub\software-design-principles\Lab4\TF2.txt"
    try:
        with open(output_path, 'r', encoding='utf-8') as file:
            content = file.read()
            text_area.delete(1.0, tk.END)
            text_area.insert(tk.END, content)
            status_var.set("Вміст TF_2 завантажено")
    except Exception as e:
        messagebox.showerror("Помилка", f"Не вдалося відкрити TF_2: {e}")
        status_var.set("Помилка при відкритті TF_2")
    pass

root = tk.Tk()
root.title("Window")
root.geometry("600x400")

button_frame = tk.Frame(root)
button_frame.pack(pady=10)


btn_create_file = tk.Button(button_frame, text="Створити TF_1", width=20, command=tf1)
btn_create_file.grid(row=0, column=0, padx=5, pady=5)

btn_find_doubles = tk.Button(button_frame, text="Знайти слова з подвоєннями", width=25, command=find_doubles)
btn_find_doubles.grid(row=0, column=1, padx=5, pady=5)

btn_show_tf2 = tk.Button(button_frame, text="Показати TF_2", width=20, command=show_tf2)
btn_show_tf2.grid(row=0, column=2, padx=5, pady=5)

output_label = tk.Label(root, text="Вміст TF_2:")
output_label.pack(pady=5)

text_area = scrolledtext.ScrolledText(root, width=70, height=15)
text_area.pack(padx=10, pady=5)

status_var = tk.StringVar()
status_var.set("Готово")
status_bar = tk.Label(root, textvariable=status_var, bd=1, relief=tk.SUNKEN, anchor=tk.W)
status_bar.pack(side=tk.BOTTOM, fill=tk.X)

root.mainloop()
