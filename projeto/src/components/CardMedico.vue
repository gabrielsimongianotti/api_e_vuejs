<template>
  <div>
    <div id="card">
      <div id="editDelete">
      <a><img src="../assets/delete.png"></a>
      <a href="#/EditarMedico"><img src="../assets/edit.png"></a>
      </div>
      <div id="dados">
      <p>cartão: {{crm}}</p>
      <p>nome: {{nome}}</p>
      </div>
    </div>
  
  </div>
</template>

<script>
export default {
  name: 'ErrorsMessages',
  props: {
    crm: String,
    nome: String
  },
  computed: {
    messageClass () {
      return {
        'md-invalid': this.hasMessages
      }
    }
  }
}
</script>

<style>
 
  #card {
    padding: 8px;
    background-color:#dfe5e8;
    text-align: right;
    width: 96%;
    margin: 2%;

  }
  p {
    text-indent: 50px;
    text-align: justify;
    letter-spacing: 3px;
  }
  #editDelete{
    margin: 10px 0px 0px 90%;
    
    position: absolute;
  }
  @media only screen and (max-width:1000px) {
  #editDelete {
    margin: 10px 0px 0px 85%;
  } 
  @media only screen and (max-width:700px) {
  #editDelete {
    margin: 10px 0px 0px 80%;
  } 
  @media only screen and (max-width:600px) {
  #editDelete {
    margin: 10px 0px 0px 75%;
  }
  }
  }
  }
  #dados{
    position:relative;
    margin: 0px 30px 0px 0px;
  }
</style>
