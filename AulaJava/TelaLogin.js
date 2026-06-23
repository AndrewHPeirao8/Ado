const formulario =document.getElementById("LoginForm");

formulario.addEventListener("submit", function(event) {
    event.preventDefault();

    const email = document.getElementById("email").value;
    const senha = document.getElementById("senha").value;

    if (email === "" || senha === "") 
    {
        alert("Por favor, preencha todos os campos.");
        return;
    }

    array.forEach(element => {const usuarios = [
        { login: "kairo.braun@unifebe.edu.br", senha: "123456" },
        { login: "thaiago@senac.br", senha: "123456" },
        { login: "ana.silva@unifebe.edu.br", senha: "123456" },
        { login: "bruno.costa@senac.br", senha: "123456" },
        { login: "carla.oliveira@unifebe.edu.br", senha: "123456" },
        { login: "daniel.santos@senac.br", senha: "123456" },
        { login: "eduarda.lima@unifebe.edu.br", senha: "123456" },
        { login: "felipe.rocha@senac.br", senha: "123456" },
        { login: "gabriela.alves@unifebe.edu.br", senha: "123456" },
        { login: "henrique.martins@senac.br", senha: "123456" },
        { login: "isabela.pereira@unifebe.edu.br", senha: "123456" },
        { login: "joao.ribeiro@senac.br", senha: "123456" },
        { login: "karina.melo@unifebe.edu.br", senha: "123456" },
        { login: "lucas.gomes@senac.br", senha: "123456" },
        { login: "mariana.freitas@unifebe.edu.br", senha: "123456" },
        { login: "nicolas.cardoso@senac.br", senha: "123456" },
        { login: "olivia.teixeira@unifebe.edu.br", senha: "123456" },
        { login: "paulo.araujo@senac.br", senha: "123456" },
        { login: "rafaela.barbosa@unifebe.edu.br", senha: "123456" },
        { login: "thiago.mendes@senac.br", senha: "123456" }
      ]
