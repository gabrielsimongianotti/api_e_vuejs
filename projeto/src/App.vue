<template>
  <main class="phone-viewport">
    <md-toolbar>
      <md-button class="md-icon button" @click.native="toggleLeftSidenav">
        <md-icon>menu</md-icon>
      </md-button>

      <h2 class="md-title">{{ title }}</h2>
    </md-toolbar>

    <md-sidenav class="md-left" ref="leftSidenav" @open="open('Left')" @close="close('Left')">
      <md-toolbar>
        <div class="md-toolbar-container">
          <h3 class="md-title">Navegação</h3>
        </div>
      </md-toolbar>

      <md-list @click.native="closeLeftSidenav">
        <md-list-item>
          <router-link to="/paciente">Paciente</router-link>
        </md-list-item>
        <md-list-item>
          <router-link to="/medico">Médico</router-link>
        </md-list-item>
        <md-list-item>
          <router-link to="/solicitacoes">Solicitações</router-link>
        </md-list-item>
        <md-list-item>
          <router-link to="/frequencias">Frequências</router-link>
        </md-list-item>
      </md-list>
   </md-sidenav>

   <md-row>
     <router-view></router-view>
   </md-row>
  </main>
</template>

<script>
export default {
  name: 'SistemaPlanoDeSaude',

  data () {
    return {
      title: 'Sistema Plano de Saude'
    }
  },

  methods: {
    toggleLeftSidenav () {
      this.$refs.leftSidenav.toggle()
    },

    closeLeftSidenav () {
      this.$refs.leftSidenav.close()
    },

    open (ref) {
      console.log('Menu aberto: ' + ref)
    },

    close (ref) {
      console.log('Menu fechado: ' + ref)
    }
  }
}
</script>

<style>
</style>
