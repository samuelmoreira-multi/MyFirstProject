# Meu Primeiro Ambiente VR — Floresta (Meta Quest)

Projeto em Unity (VR) com um ambiente simples de **floresta**, criado para demonstrar fundamentos básicos de XR/VR:

- cena navegável
- chão/terreno e ambiente configurados
- organização do projeto
- build preparado para **Android (Meta Quest)**
- testes no **PC (Unity Editor)**

---

## Tecnologias / Pacotes

- **Unity:** 6.3 LTS
- **Meta XR (SDK / Building Blocks)**
- **OpenXR (XR Plug-in Management)**
  - **Meta Quest Support** habilitado no Android

---

## Assets utilizados

Este projeto **não possui assets próprios** (modelos/texturas/materiais autorais).
A cena foi montada utilizando **somente os assets do pacote abaixo**:

- **Environment Pack: Free Forest Sample** (Unity Asset Store)
  - Link: https://assetstore.unity.com/packages/3d/vegetation/environment-pack-free-forest-sample-168396

> Observação: foram usados **prefabs/objetos prontos do pacote** (árvores, pedras, vegetação e props), além de ajustes de posicionamento/escala e configuração de cena.

---

## Requisitos atendidos (checklist)

### 1) Configuração Técnica

- [x] Projeto Unity compatível com Meta XR
- [x] Meta XR SDK instalado e configurado (Building Blocks)
- [x] XR Plugin Management configurado com OpenXR (Android)
- [x] Build preparado para Android (Meta Quest)
- [x] Movimentação/testes no PC (Play Mode no Editor), sem depender do óculos

### 2) Ambiente Virtual

- [x] 5+ objetos 3D na cena (todos do pack)
- [x] Chão/terreno onde o usuário pode caminhar (Terrain/ground com colisão)
- [x] Skybox configurado
- [x] Ambiente coerente (floresta simples)

### 3) Organização e Qualidade

- [x] Hierarquia organizada em grupos (XR / Terrain / Environment / Props / Lighting)
- [x] Nomenclatura consistente
- [x] Projeto limpo no Git (sem pastas geradas)
- [x] Documentação (este README)

---

## Como testar no PC (sem Meta Quest)

1. Abra a cena `SampleScene`
2. Clique **Play**
3. Navegue usando o setup de simulação configurado no projeto

> Dica: mantenha apenas **um** rig/câmera ativa por vez para evitar conflitos.

---

## Como buildar para Meta Quest (Android)

1. **File > Build Profiles**
2. Selecione **Android**
3. Em **Scene List**, deixe `SampleScene.unity` como a **primeira cena**
4. **Build** ou **Build And Run**

---

## Estrutura de pastas (organização)

- `Assets/_Project/Scenes` — cenas do projeto
- `Assets/_Project/Prefabs` — prefabs finais (se você criou variações/organizou instâncias)
- `Assets/_Project/Art` — materiais/texturas (caso tenha organizado/ajustado)
- `Assets/_Project/Docs` — documentação
- `Assets/ThirdParty/...` — conteúdo importado do pacote (mantido separado)

---

## Créditos e Licença

- Os modelos, texturas e prefabs utilizados pertencem ao pacote **Environment Pack: Free Forest Sample** e seguem a licença padrão do Unity Asset Store.
"# MyFirstProject" 
