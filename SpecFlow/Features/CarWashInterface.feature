﻿#language: ru
@all @CarWashInterface
Функция: Интерфейс мойки
	UI-проверки

Предыстория: Вход в аккаунт мойки
* Клик по кнопке Вход для Клиентов
* Авторизация в тестовый аккаунт мойки

@ITimoshenko @положительный
Сценарий: Сброс введенных данных
* Ввод тестового госномера
* Выбор типа услуги
* Выполнение сброса и проверка

@ITimoshenko @положительный
Сценарий: Сброс введенных данных с запросом
* Ввод тестового госномера
* Выбор типа услуги
* Запросить
* Выполнение сброса и проверка двух полей

@ITimoshenko @положительный
Сценарий: Поле промокодов
* Клик по кнопке промокоды
* Проверка появления поля промокоды
* Клик по кнопке Х
* Проверка закрытия поля промокоды

@ITimoshenko @положительный
Сценарий: Поле ввода госномера
* Ввод тестового госномера
* Выбор типа услуги
* Запросить
* Проверка открытия поля ввода номера телефона

