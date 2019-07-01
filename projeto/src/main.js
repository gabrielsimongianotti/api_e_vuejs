/* eslint-disable standard/object-curly-even-spacing */
import Vue from 'vue'
import App from './App'
import VueRouter from 'vue-router'

import VueMaterial from 'vue-material'
import 'vue-material/dist/vue-material.css'

import Menu from './components/menu.vue'
import Frequencias from './components/Frequencias.vue'
import Solicitacoes from './components/Solicitacoes.vue'
import Medico from './components/Medico.vue'
import Paciente from './components/Paciente.vue'
// cadastro
import CFrequencias from './components/cadastro/CadFrequencias.vue'
import CSolicitacoes from './components/cadastro/CadSolicitacoes.vue'
import CMedico from './components/cadastro/CadMedico.vue'
import CPaciente from './components/cadastro/CadPaciente.vue'
// editar
import EFrequencias from './components/editar/EditarFrequencias.vue'
import ESolicitacoes from './components/editar/EditarSolicitacoes.vue'
import EMedico from './components/editar/EditarMedico.vue'
import EPaciente from './components/editar/EditarPaciente.vue'

Vue.config.productionTip = false
Vue.use(VueMaterial)
Vue.use(VueRouter)

const routes = [
  { path: '/', component: Menu },
  { path: '/frequencias', component: Frequencias },
  { path: '/solicitacoes', component: Solicitacoes },
  { path: '/medico', component: Medico },
  { path: '/paciente', component: Paciente },
  // Cadastro
  { path: '/CadastroFrequencias', component: CFrequencias },
  { path: '/CadastroSolicitacoes', component: CSolicitacoes },
  { path: '/CadastroMedico', component: CMedico },
  { path: '/CadastroPaciente', component: CPaciente },
  // Editar
  { path: '/EditarFrequencias', component: EFrequencias},
  { path: '/EditarSolicitacoes', component: ESolicitacoes},
  { path: '/EditarMedico', component: EMedico},
  { path: '/EditarPaciente', component: EPaciente}
]

const router = new VueRouter({
  routes
})

Vue.material.registerTheme('default', {
  primary: 'blue',
  accent: 'blue',
  warn: 'red'
})

/* eslint-disable no-new */
new Vue({
  router,
  render: h => h(App)
}).$mount('#app')
