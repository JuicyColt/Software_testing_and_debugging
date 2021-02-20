import pywinauto
from pywinauto.application import Application
import time

app = pywinauto.application.Application()

path = '.\\Lab1_Seldin\\bin\\Debug\\Lab1_Seldin.exe'

app.start(path)
time.sleep(1)

#app['MainForm'].PrintControlIdentifiers()
test_list = {"asdasdasd": "asd",
             "123": "123",
             "aswe1233asw": "aswe123"}

test_list1 = {"asdq": "qasd",
              "a": "a",
              "123123": "312312"}

Edit = app['MainForm'].child_window(auto_id="textBox1",
                                    control_type="System.Windows.Forms.TextBox")
button2 = app['MainForm'].child_window(title="перенести последнюю букву в начало слова",
                                       auto_id="START",
                                       control_type="System.Windows.Forms.Button")
button1 = app['MainForm'].child_window(title="удалить из слова повторные вхождения каждой буквы",
                                       auto_id="button1",
                                       control_type="System.Windows.Forms.Button")
for i in test_list:
    Edit.set_text(i)
    time.sleep(1)
    button1.click()
    print(f'input = {i}, result = {Edit.texts()[0]}, expect = {test_list[i]}')
    assert Edit.texts()[0] == test_list[i], 'Not passed'

for i in test_list1:
    Edit.set_text(i)
    time.sleep(1)
    button2.click()
    print(f'input = {i}, result = {Edit.texts()[0]}, expect = {test_list1[i]}')
    assert Edit.texts()[0] == test_list1[i], 'Not passed'

app.window(title="MainForm").close()
