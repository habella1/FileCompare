# (C# 코딩) 7주차 과제: File Compare
-이름: 하다현 (24018097)

## 개요
- C# 프로그래밍 학습
- 1줄 소개: 두 개의 폴더를 선택하여 파일 목록을 비교하고 관리할 수 있는 Windows Forms 기반 프로그램
- 사용한 플랫폼: C#, .NET Windows Forms, Visual Studio, GitHub, Visual Code
- 사용한 컨트롤: SplitContainer, Panel, Button, Label, ListView, textBox
- 사용한 기술과 구현한 기능:
  - Visual Studio를 이용하여 UI 디자인
  - 메뉴 선택 기능: RadioButton을 활용한 단일 메뉴 선택
  - 옵션 선택 기능: CheckBox를 활용한 복수 선택 처리
  - 가격 계산 기능: 선택된 항목들의 가격을 합산
  - 이벤트 처리: 버튼 클릭 시 전체 로직 실행
  - 조건문 활용: 선택 여부에 따른 분기 처리
  - UI 업데이트: 사용자 입력에 따라 화면 즉시 반영

---

## 실행 화면 (과제1)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제1 실행화면](img/screenshot-1.png)

- 구현한 내용( 위 그림 참조 )
  - 컨트롤을 위치에 맞게 배치하였다.
  - 화면을 좌측과 우측으로 나누기 위해 SplitContainer 사용하였고, Dock 속성을 Fill로 설정하여 form 크기에 맞게 자동으로 확장되도록 하였다.
  - 좌측과 우측 영역에 각각 3개씩 Panel을 배치하였다.
  - SplitContainer을 움직여도 버튼, 텍스트박스, 리스트뷰가 유지되도록 Anchor 속성을 설정해 고정시켰다.
  - ListView는 영역 전체를 채우도록 Dock을 Fill로 설정하여 가독성을 높였다.

    cf) Label("File Compare") -> lblAppName
	Button-">>>(왼쪽)" -> btnLeftDir
		 -">>>(오른쪽)" -> btnRightDir
		 -"폴더선택(왼)" -> btnCopyFromLeft
		 -"폴더선택(오)" -> btnCopyFromRight
	textBox - 왼 -> txtLeftDir
	textBox - 오 -> txtRightDir
	ListView - 왼 -> lvwLeftDir
	           - 오 -> lvwRightDir

 ---

## 실행 화면 (과제2)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제2 실행화면](img/screenshot-2.png)

- 구현한 내용 (위 그림 참조)
  - FolderBrowserDialog를 사용하여 폴더 선택 기능을 구현하였다.
  - “폴더선택(왼쪽)” 버튼(btnLeftDir) 클릭 시 FolderBrowserDialog를 생성하고 ShowDialog()를 통해 폴더 선택 창을 출력하였다.
  - 사용자가 폴더를 선택하고 확인 버튼을 누르면 SelectedPath 속성을 이용하여 선택한 폴더의 전체 경로를 텍스트박스(txtLeftDir)가져온다.
  - 
  - SelectedPath 사용

---

## 실행 화면 (과제3)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제3 실행화면](img/screenshot-3.png)

- 구현한 내용 (위 그림 참조)

---

## 실행 화면 (과제4)
- 코드의 실행 스크린샷과 구현 내용 설명

![과제4 실행화면](img/screenshot-4.png)

- 구현한 내용 (위 그림 참조)

---

## +) 기능 설명

### 1단계 - 기본 UI 배치 및 기능 구현
  1. UI구성
    - RadioButton과 CheckBox 등을 적절히 배치
    - GroupBox로 적절하게 그룹으로 묶기

  2. GroupBox로 적절하게 그룹으로 묶기
    - RadioButton 한 그룹으로 묶고, CheckBox끼리 한 그룹으로 묶고, ListBox와 총 금액 표시하는 Label 하나로 묶기

  3. 주문하기 버튼과 초기화 버튼 기능 구현
    - ListBox에 주문 내역, Label에 총 금액 표시(총 금액: 0원)
    - 다시 주문할 수 있도록 초기화 버튼 구현

### 2단계 - 에러 표시 개선
  1. 화면 내 오류 표시
    - Label을 이용해 아이디 또는 패스워드가 잘못 입력됐을 때 에러 메시지를 화면에 표시
    - Visible 속성을 이용해 메시지 보이기와 숨기기 기능 구현
  2. UX 개선
    - 사용자에게 즉각적인 피드백 제공
    - 불필요한 MessageBox 사용 최소화

### 3단계 - UX 개선(사용자 편의성 향상)
  1. Enter 키를 누르면 로그인 되도록 포커스 흐름 정리
   - 아이디 입력 -> Enter 누르면 패스워드 입력 창으로 넘어가기
   - 패스워드 입력 -> Enter누르면 로그인 시작하기

  2. 추가 기능
    - 전체 입력 삭제 기능
    - 패스워드를 보여주는 기능(보기/숨기기 가능)
   

### 4단계 - 데이터 관리 및 심화 기능
  1. 아이디와 패스워드 입력 문자 확인
    - 아이디에 넣을 수 없는 글자 체크
    - 비밀번호에 넣을 수 없거나 꼭 들어가야 하는 문자 체크
  2. 로그인 시도 제한
    - 일정 회수가 지나면 정해진 시간 후에 재시도 가능하게
    -  한 단계 더 체크하기
    - 조금 더 복잡하고 

     
---

## 구현 시 어려웠던 점
- 