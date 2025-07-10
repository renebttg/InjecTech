# 🚗 InjecTech

**InjecTech** é um simulador de injeção eletrônica automotiva desenvolvido em **C# com WPF**, que demonstra como uma **ECU (Unidade de Controle Eletrônico)** toma decisões baseadas nos sinais de sensores do motor para controlar o tempo de injeção de combustível. O projeto foi criado com o objetivo de conectar um interesse pessoal (injeção eletrônica) com o desenvolvimento de software, sendo apresentado em um evento técnico interno.

---

## 💡 Objetivo

O projeto visa **simular o funcionamento de uma ECU programável**, permitindo ao usuário alterar valores de sensores (como RPM, temperatura, TPS e oxigênio) por meio de sliders, visualizando em tempo real como a lógica da injeção responde a essas mudanças. Ideal para fins educacionais e demonstrações técnicas.

---

## 🧠 Como Funciona

A lógica da ECU calcula o tempo de injeção com base nos seguintes parâmetros:

- **RPM (rotações por minuto)** do motor
- **Temperatura** do motor em graus Celsius
- **TPS (posição da borboleta)** em porcentagem
- **Sensor Lambda (oxigênio)** para avaliar a mistura ar-combustível

A equação utilizada para o tempo de injeção é:

```csharp
tempoInjecao = (rpm / 1000) * (1 + (tps / 100.0)) * (temp > 80 ? 0.9 : 1.2)
```


A mistura ar-combustível é classificada como:

- 🔴 **Pobre** (lambda > 1.02)
- 🟡 **Rica** (lambda < 0.98)
- 🟢 **Estequiométrica** (entre 0.98 e 1.02)

---

## 🧱 Estrutura do Projeto


```
InjecTech/  
│  
├── Domain/  
│ ├── Models/ # Sensores e atuadores (SensorRPM, SensorTPS, BicoInjetor, etc.)  
│ └── Core/ # Lógica da ECU (ECU.cs)  
│  
└── View/  
└── InjectSimView.xaml # Interface gráfica com sliders e exibição do status
```


---

## 🖼️ Interface

A interface foi construída em **WPF** com sliders para:

- RPM (0 a 8000)
- Temperatura (20°C a 120°C)
- TPS (0% a 100%)
- Lambda (0.8 a 1.2)

Após clicar em **“Processar Injeção”**, o sistema exibe:

- Tempo de injeção em milissegundos
- Estado dos sensores
- Classificação da mistura

---

## 🔧 Tecnologias Utilizadas

- **C#**
- **.NET WPF**
- **MVVM-like Architecture**
- Aplicação Desktop (Windows)

---

## 👨‍💻 Autor

**Rene Battaglia**  
Desenvolvedor de Software e entusiasta de injeção eletrônica automotiva  
🔗 [LinkedIn](https://www.linkedin.com/in/rene-battaglia) 

---

## 🧪 Possíveis Expansões

- Registro de logs de simulação
- Simulação gráfica do motor
- Controle fechado com feedback do sensor lambda
- Integração com Arduino para testes físicos

---

## 📜 Licença

Este projeto é de uso educacional. Licenciamento a ser definido.
