import tkinter as tk
from tkinter import ttk, messagebox

class Organization:
    def __init__(self, name="Unknown", address="Unknown", employees=0):
        self.name = name
        self.address = address
        self.employees = employees

    @classmethod
    def from_other(cls, other):
        return cls(other.name, other.address, other.employees)

    def __del__(self):
        print("Лабораторна робота виконанна студентом 2 курсу Граневськийм Богданом")

    def show(self):
        return (f"Назва організації: {self.name}\n"
                f"Адреса: {self.address}\n"
                f"Кількість працівників: {self.employees}")

    def activity(self):
        return "Організація займається загальною господарською діяльністю."


class InsuranceCompany(Organization):
    def __init__(self, name="Unknown", address="Unknown", employees=0,
                 insurance_type="Unknown", insurance_fund=0.0, clients=0):
        super().__init__(name, address, employees)
        self.insurance_type = insurance_type
        self.insurance_fund = insurance_fund
        self.clients = clients

    def show(self):
        base = super().show()
        return (f"{base}\nТип страхування: {self.insurance_type}\n"
                f"Страховий фонд: {self.insurance_fund} грн\n"
                f"Кількість клієнтів: {self.clients}")

    def activity(self):
        return "Компанія займається страхуванням життя та майна клієнтів."


class OilGasCompany(Organization):
    def __init__(self, name="Unknown", address="Unknown", employees=0,
                 production_volume=0.0, export_volume=0.0, main_region="Unknown"):
        super().__init__(name, address, employees)
        self.production_volume = production_volume
        self.export_volume = export_volume
        self.main_region = main_region

    def show(self):
        base = super().show()
        return (f"{base}\nОбсяг видобутку: {self.production_volume} тонн\n"
                f"Обсяг експорту: {self.export_volume} тонн\n"
                f"Основний регіон: {self.main_region}")

    def activity(self):
        return "Компанія займається видобутком і експортом нафти та газу."


class Factory(Organization):
    def __init__(self, name="Unknown", address="Unknown", employees=0,
                 product_type="Unknown", capacity=0, safety_level="Unknown"):
        super().__init__(name, address, employees)
        self.product_type = product_type
        self.capacity = capacity
        self.safety_level = safety_level

    def show(self):
        base = super().show()
        return (f"{base}\nТип продукції: {self.product_type}\n"
                f"Потужність виробництва: {self.capacity} одиниць/день\n"
                f"Рівень безпеки: {self.safety_level}")

    def activity(self):
        return "Завод виробляє промислову продукцію та контролює якість."


class OrganizationApp:
    def __init__(self, root):
        self.root = root
        self.root.title("Організації — Лабораторна робота")
        self.root.geometry("600x600")

        self.org_type = tk.StringVar(value="Organization")
        self.entries = {}

        ttk.Label(root, text="Оберіть тип організації:", font=("Arial", 12)).pack(pady=5)
        ttk.Combobox(root, textvariable=self.org_type, values=[
            "Organization", "InsuranceCompany", "OilGasCompany", "Factory"
        ]).pack(pady=5)

        ttk.Button(root, text="Створити форму", command=self.build_form).pack(pady=10)

        self.form_frame = ttk.Frame(root)
        self.form_frame.pack()

        self.output = tk.Text(root, height=12, width=65)
        self.output.pack(pady=10)

        ttk.Button(root, text="Показати дані", command=self.show_data).pack(pady=5)
        ttk.Button(root, text="Показати діяльність", command=self.show_activity).pack(pady=5)

        self.obj = None

    def build_form(self):
        for widget in self.form_frame.winfo_children():
            widget.destroy()

        base_fields = ["Назва", "Адреса", "Кількість працівників"]
        extra_fields = []

        org_type = self.org_type.get()

        if org_type == "InsuranceCompany":
            extra_fields = ["Тип страхування", "Страховий фонд", "Кількість клієнтів"]
        elif org_type == "OilGasCompany":
            extra_fields = ["Обсяг видобутку", "Обсяг експорту", "Основний регіон"]
        elif org_type == "Factory":
            extra_fields = ["Тип продукції", "Потужність", "Рівень безпеки"]

        all_fields = base_fields + extra_fields

        self.entries.clear()
        for field in all_fields:
            ttk.Label(self.form_frame, text=field).pack()
            entry = ttk.Entry(self.form_frame, width=40)
            entry.pack(pady=2)
            self.entries[field] = entry

        ttk.Button(self.form_frame, text="Створити об’єкт", command=self.create_object).pack(pady=10)

    def create_object(self):
        try:
            name = self.entries["Назва"].get()
            address = self.entries["Адреса"].get()
            employees = int(self.entries["Кількість працівників"].get())

            org_type = self.org_type.get()

            if org_type == "Organization":
                self.obj = Organization(name, address, employees)
            elif org_type == "InsuranceCompany":
                insurance_type = self.entries["Тип страхування"].get()
                insurance_fund = float(self.entries["Страховий фонд"].get())
                clients = int(self.entries["Кількість клієнтів"].get())
                self.obj = InsuranceCompany(name, address, employees, insurance_type, insurance_fund, clients)
            elif org_type == "OilGasCompany":
                production = float(self.entries["Обсяг видобутку"].get())
                export = float(self.entries["Обсяг експорту"].get())
                region = self.entries["Основний регіон"].get()
                self.obj = OilGasCompany(name, address, employees, production, export, region)
            elif org_type == "Factory":
                product_type = self.entries["Тип продукції"].get()
                capacity = int(self.entries["Потужність"].get())
                safety = self.entries["Рівень безпеки"].get()
                self.obj = Factory(name, address, employees, product_type, capacity, safety)

            messagebox.showinfo("Успіх", f"{org_type} успішно створено!")

        except Exception as e:
            messagebox.showerror("Помилка", f"Некоректні дані!\n{e}")

    def show_data(self):
        if self.obj is None:
            messagebox.showwarning("Увага", "Спочатку створіть об’єкт!")
            return
        self.output.delete("1.0", tk.END)
        self.output.insert(tk.END, self.obj.show())

    def show_activity(self):
        if self.obj is None:
            messagebox.showwarning("Увага", "Спочатку створіть об’єкт!")
            return
        self.output.delete("1.0", tk.END)
        self.output.insert(tk.END, self.obj.activity())


root = tk.Tk()
app = OrganizationApp(root)
root.mainloop()
